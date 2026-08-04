-- Tables pour la gestion des groupes
-- A executer dans la base de donnees "reseaux_sociaux"

CREATE TABLE IF NOT EXISTS groupe (
    groupe_id SERIAL PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    description TEXT NOT NULL DEFAULT '',
    createur_id INTEGER NOT NULL REFERENCES etudiant(id) ON DELETE CASCADE,
    date_creation TIMESTAMPTZ NOT NULL DEFAULT NOW()
);

CREATE TABLE IF NOT EXISTS groupe_membre (
    groupe_id INTEGER NOT NULL REFERENCES groupe(groupe_id) ON DELETE CASCADE,
    etudiant_id INTEGER NOT NULL REFERENCES etudiant(id) ON DELETE CASCADE,
    role VARCHAR(30) NOT NULL DEFAULT 'Membre',
    date_ajout TIMESTAMPTZ NOT NULL DEFAULT NOW(),
    PRIMARY KEY (groupe_id, etudiant_id)
);

CREATE TABLE IF NOT EXISTS groupe_message (
    message_id SERIAL PRIMARY KEY,
    groupe_id INTEGER NOT NULL REFERENCES groupe(groupe_id) ON DELETE CASCADE,
    etudiant_id INTEGER NOT NULL REFERENCES etudiant(id) ON DELETE CASCADE,
    content TEXT NOT NULL DEFAULT '',
    time_sent TIMESTAMPTZ NOT NULL DEFAULT NOW()
);
